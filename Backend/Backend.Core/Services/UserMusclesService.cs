﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Backend.Core.Interfaces;
using Backend.Core.Models.UserMuscles;
using Backend.Infrastructure.Data;
using Backend.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Core.Services
{
    public class UserMusclesService : IUserMusclesService
    {
        /// <summary>
        /// Entity Framework DbContext.
        /// </summary>
        private readonly ApplicationContext _context;

        public UserMusclesService(ApplicationContext context)
        {
            _context = context;
        }

        public List<UserMuscleSmallDesc> GetUserMuscles(int userId)
        {
            var userMuscles = _context
                .UserMuscles.Include(x => x.Muscle)
                .Include(x => x.User)
                .Where(x => x.UserId == userId)
                .ToList();
            var resList = new List<UserMuscleSmallDesc>();

            foreach (var userMuscle in userMuscles)
            {
                var muscle = _context.Muscles.FirstOrDefault(x =>
                    x.MuscleId == userMuscle.MuscleId
                );
                var resMuscle = new UserMuscleSmallDesc
                {
                    Id = muscle.MuscleId,
                    Name = muscle.Name,
                    UrlImage = muscle.UrlImage
                };

                resMuscle.Percentage = userMuscle.MusclePoints;
                resList.Add(resMuscle);
                _context.SaveChanges();
            }
            resList = resList.OrderByDescending(x => x.Percentage).ThenBy(x => x.Name).ToList();
            return resList;
        }

        public HttpStatusCode UpdateUserMuscles(MusclesForUpdate userMuscles)
        {
            foreach (var target in userMuscles.Target)
            {
                var targetMuscle = _context.UserMuscles.FirstOrDefault(x =>
                    x.MuscleId == target && x.UserId == userMuscles.UserId
                );
                if (targetMuscle == null)
                {
                    var muscle = _context.Muscles.FirstOrDefault(x => x.MuscleId == target);
                    if (muscle == null)
                        return HttpStatusCode.BadRequest;
                    var userMuscle = new UserMuscles()
                    {
                        UserId = userMuscles.UserId,
                        MuscleId = target,
                        MusclePoints = 10
                    };
                    _context.Add(userMuscle);
                }
                else
                {
                    targetMuscle.MusclePoints += 10;
                }
            }

            foreach (var synergist in userMuscles.Synergists)
            {
                var synergistMuscle = _context.UserMuscles.FirstOrDefault(x =>
                    x.MuscleId == synergist && x.UserId == userMuscles.UserId
                );
                if (synergistMuscle == null)
                {
                    var muscle = _context.Muscles.FirstOrDefault(x => x.MuscleId == synergist);
                    if (muscle == null)
                        return HttpStatusCode.BadRequest;
                    var userMuscle = new UserMuscles()
                    {
                        UserId = userMuscles.UserId,
                        MuscleId = synergist,
                        MusclePoints = 5
                    };
                    _context.Add(userMuscle);
                }
                else
                {
                    synergistMuscle.MusclePoints += 5;
                }
            }
            _context.SaveChanges();

            return HttpStatusCode.OK;
        }
    }
}
