﻿using Backend.Core.Interfaces;
using Backend.Core.Models.Achievments;
using Backend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Core.Services
{
    public class AchievmentService : IAchievmentService
    {
        /// <summary>
        /// Entity Framework DbContext.
        /// </summary>
        private readonly ApplicationContext _context;
        public AchievmentService(ApplicationContext context)
        {
            _context = context;
        }

        public AchievmentSmallDesc? TrainingAchievements(int userId)
        {
            var user = _context.Users
                .Include(x => x.UserSetsOfExercises)
                .ThenInclude(x => x.UserSetTrainings)
                .Include(x => x.BasicalSetTrainings)
                .FirstOrDefault(x => x.UserId == userId);

            if (user?.UserSetsOfExercises == null || user.BasicalSetTrainings == null)
                return null;

            var totalTrainings = user.UserSetsOfExercises.Sum(set => set.UserSetTrainings.Count) + user.BasicalSetTrainings.Count;

            return totalTrainings switch
            {
                1 => new AchievmentSmallDesc { AchievmentId = 1, Desc = "Finish Your First Training Session", Name = "First Steps" },
                10 => new AchievmentSmallDesc { AchievmentId = 2, Desc = "Finish 10 Training Sessions", Name = "On The Right Way" },
                50 => new AchievmentSmallDesc { AchievmentId = 3, Desc = "Finish 50 Training Sessions", Name = "You got better" },
                _ => null
            };
        }

        public AchievmentSmallDesc? Is5BasicalTrainings(int userId)
        {
            var user = _context.Users.Include(x => x.BasicalSetTrainings).FirstOrDefault(x => x.UserId == userId);
            if (user?.BasicalSetTrainings == null)
                return null;

            int count = user.BasicalSetTrainings.Count;
            return count == 5
                ? new AchievmentSmallDesc { AchievmentId = 4, Desc = "Finish 5 Basical Training Sessions", Name = "Learn From The Best" }
                : null;
        }

        public AchievmentSmallDesc? Is5OwnTrainings(int userId)
        {
            var user = _context.Users.Include(x => x.UserSetsOfExercises).ThenInclude(x => x.UserSetTrainings).FirstOrDefault(x => x.UserId == userId);
            if (user?.UserSetsOfExercises == null)
                return null;

            int count = 0;
            foreach (var userSet in user.UserSetsOfExercises)
                count += userSet.UserSetTrainings?.Count ?? 0;

            return count == 5
                ? new AchievmentSmallDesc { AchievmentId = 5, Desc = "Finish 5 Your Own Trainings", Name = "Train On Your Own" }
                : null;
        }

        public HttpStatusCode PutAchievment(int achievmentId, int userId)
        {
            var userAchievment = _context.UserAchievments
                                         .FirstOrDefault(x => x.UserId == userId && x.AchievmentId == achievmentId);
            if (userAchievment == null)
            {
                return HttpStatusCode.NotFound;
            }

            userAchievment.IsDone = true;
            _context.SaveChanges();

            return HttpStatusCode.OK;
        }

        public List<AchievmentFull> GetAllAchievments(int userId)
        {
            var resList = new List<AchievmentFull>();
            var user = _context.Users.Include(x => x.UsersAchievments).ThenInclude(x => x.Achievment).FirstOrDefault(x => x.UserId == userId);

            if (user?.UsersAchievments == null)
                return resList;

            foreach (var userAchievment in user.UsersAchievments)
            {
                var achievment = userAchievment.Achievment;
                if (achievment == null)
                    continue;

                resList.Add(new AchievmentFull
                {
                    AchievmentId = userAchievment.AchievmentId,
                    Description = achievment.Description,
                    Name = achievment.Name,
                    IsDone = userAchievment.IsDone,
                    Image = achievment.UrlImage
                });
            }

            return resList;
        }

        public AchievmentSmallDesc? IsResearcher(int userId)
        {
            var achievement = _context.UserAchievments
                                      .Include(x => x.Achievment)
                                      .FirstOrDefault(x => x.UserId == userId && x.AchievmentId == 7);

            if (achievement == null || achievement.Achievment == null || achievement.IsDone)
            {
                return null;
            }
            else
            {
                return new AchievmentSmallDesc
                {
                    Desc = achievement.Achievment.Description,
                    AchievmentId = achievement.AchievmentId,
                    Name = achievement.Achievment.Name
                };
            }
        }

        public AchievmentSmallDesc? IsCreator(int userId)
        {
            var achievement = _context.UserAchievments
                                      .Include(x => x.Achievment)
                                      .FirstOrDefault(x => x.UserId == userId && x.AchievmentId == 6);

            if (achievement == null || achievement.Achievment == null || achievement.IsDone)
            {
                return null;
            }
            else
            {
                return new AchievmentSmallDesc
                {
                    Desc = achievement.Achievment.Description,
                    AchievmentId = achievement.AchievmentId,
                    Name = achievement.Achievment.Name
                };
            }
        }
    }
}
