﻿using Backend.Core.Interfaces;
using Backend.Core.Models.BasicSets;
using Backend.Core.Models.UserMuscles;
using Backend.Infrastructure.Data;
using Backend.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

// Add to review
namespace Backend.Core.Services
{
    public class BasicSetService : IBasicSetService
    {
        /// <summary>
        /// Entity Framework DbContext.
        /// </summary>
        private readonly ApplicationContext _context;
        public BasicSetService(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets all basical sets from section.
        /// </summary>
        /// <param name="section">Section of sets.</param>
        /// <returns>List of basical sets from section or null.</returns>
        public List<BasicalSetInfo>? GetBasicalSetsSmallInfoBySection(int section)
        {
            var listSectionBasicalSets = _context.BasicalSetOfExercises.Where(x => x.Section == section).ToList();
            var resList = new List<BasicalSetInfo>();
            if (listSectionBasicalSets.Count > 0)
            {
                foreach (var basicalSet in listSectionBasicalSets)
                {
                    BasicalSetInfo basicalSetInfo = new BasicalSetInfo() { Id = basicalSet.BasicalSetId, Image = basicalSet.UrlImage, Name = basicalSet.Name };
                    FillTopEfficiencyToBasicalSetInfo(basicalSet, basicalSetInfo);
                    AddBasicalSetInfoToResList(resList, basicalSetInfo);
                }

                return resList;
            }
            return null;
        }

        /// <summary>
        /// Gets basical set by id and converts it to FullInfo Model.
        /// </summary>
        /// <param name="id">Id of basical set.</param>
        /// <returns>BasicalSetFullInfo model object.</returns>
        public BasicalSetFullInfo? GetBasicalSetFullDescById(int id)
        {
            var basicalSet = _context.BasicalSetOfExercises
                .Include(x => x.BasicalSetExercises)
                .Include(x => x.BasicalSetEfficiency)
                .FirstOrDefault(x => x.BasicalSetId == id);

            if (basicalSet == null) return null;

            AddEfficiencyToSet(basicalSet);
            var efficiencyDesc = GetEfficiencyDescFromEfficiency(basicalSet.BasicalSetEfficiency);

            return new BasicalSetFullInfo
            {
                Id = id,
                Name = basicalSet.Name,
                Description = basicalSet.Description,
                Image = basicalSet.UrlImage,
                Efficiency = efficiencyDesc,
                ExerciseSmallDescs = basicalSet.BasicalSetExercises
                    .Select(exercise => CreateExerciseSmallDesc(exercise))
                    .ToList()
            };
        }

        // Helper method to create ExerciseSmallDesc
        private ExerciseSmallDesc CreateExerciseSmallDesc(BasicalSetExercise basicalSetExercise)
        {
            var exerciseSmallDescList = new List<ExerciseSmallDesc>();
            AddExerciseSmallDescToList(basicalSetExercise, exerciseSmallDescList);
            return exerciseSmallDescList.FirstOrDefault(); // Assuming only one element is added
        }


        /// <summary>
        /// Finds and fills basical set info TopEfficiency dictionary by corresponding basical set.
        /// </summary>
        /// <param name="basicalSet">Current set from which we take data to fill our info.</param>
        /// <param name="basicalSetInfo">Current set info that we fill in order to add to resultive list.</param>
        private void FillTopEfficiencyToBasicalSetInfo(BasicalSetOfExercises basicalSet, BasicalSetInfo basicalSetInfo)
        {
            AddEfficiencyToSet(basicalSet);
            Dictionary<string, int> fullEfficiency = FillEfficiencyInSet(basicalSet);
            SetTopEfficiencyToInfo(fullEfficiency, basicalSetInfo);
        }

        /// <summary>
        /// Adds current object of Basical Set Info to resultive list.
        /// </summary>
        /// <param name="resList">Resultive List of Basical Set Info.</param>
        /// <param name="basicalSetInfo">Current set info that we fill in order to add to resultive list.</param>
        private void AddBasicalSetInfoToResList(List<BasicalSetInfo> resList, BasicalSetInfo basicalSetInfo)
        {
            resList.Add(basicalSetInfo);
        }

        /// <summary>
        /// Fills the TopEfficiency dictionary property.
        /// </summary>
        /// <param name="efficiency"></param>
        /// <param name="basicalSetInfo"></param>
        private void SetTopEfficiencyToInfo(Dictionary<string, int> efficiency, BasicalSetInfo basicalSetInfo)
        {
            var a = efficiency.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            basicalSetInfo.TopEfficiency = a.Take(2).ToDictionary(x => x.Key, x => x.Value);
        }

        /// <summary>
        /// Adds efficiency from db to basical set (Crutch beacuse of error in db).
        /// </summary>
        /// <param name="basicalSet"></param>
        private void AddEfficiencyToSet(BasicalSetOfExercises basicalSet)
        {
            var currEfficiency = _context.BasicalSetEfficiencies.First(x => x.BasicalSetId == basicalSet.BasicalSetId);
            basicalSet.BasicalSetEfficiency = currEfficiency;
        }

        /// <summary>
        /// Fills the Full Efficiency Dictionary.
        /// </summary>
        /// <param name="basicalSet"></param>
        /// <returns></returns>
        private Dictionary<string, int> FillEfficiencyInSet(BasicalSetOfExercises basicalSet)
        {
            Dictionary<string, int> efficiency = new Dictionary<string, int>
            {
                { nameof(basicalSet.BasicalSetEfficiency.Abs), basicalSet.BasicalSetEfficiency.Abs },
                { nameof(basicalSet.BasicalSetEfficiency.Arms), basicalSet.BasicalSetEfficiency.Arms },
                { nameof(basicalSet.BasicalSetEfficiency.Back), basicalSet.BasicalSetEfficiency.Back },
                { nameof(basicalSet.BasicalSetEfficiency.Cardio), basicalSet.BasicalSetEfficiency.Cardio },
                { nameof(basicalSet.BasicalSetEfficiency.Chest), basicalSet.BasicalSetEfficiency.Chest },
                { nameof(basicalSet.BasicalSetEfficiency.Legs), basicalSet.BasicalSetEfficiency.Legs }
            };
            return efficiency;
        }

        /// <summary>
        /// Converts the set efficiency to efficiency desc model.
        /// </summary>
        /// <param name="basicalSetEfficiency">Efficiency of set.</param>
        /// <returns>Efficiency desc model.</returns>
        private EfficiencyDesc GetEfficiencyDescFromEfficiency(BasicalSetEfficiency basicalSetEfficiency)
        {
            return new EfficiencyDesc() { Abs = basicalSetEfficiency.Abs, Arms = basicalSetEfficiency.Arms, Back = basicalSetEfficiency.Back, Cardio = basicalSetEfficiency.Cardio, Chest = basicalSetEfficiency.Chest, Legs = basicalSetEfficiency.Legs };
        }

        /// <summary>
        /// Fills the exerciseSmallDesc model list.
        /// </summary>
        /// <param name="basicalSetExercise">Value from the intermediate table BasicalSet_Exercise.</param>
        /// <param name="exerciseSmallDescList">List of exercise small desc model.</param>
        private void AddExerciseSmallDescToList(BasicalSetExercise basicalSetExercise, List<ExerciseSmallDesc> exerciseSmallDescList)
        {
            var exercise = _context.Exercises.Include(x => x.ExerciseMuscles).First(x => x.ExerciseId == basicalSetExercise.ExerciseId);
            var exerciseMuscle = _context.ExerciseMuscles.Where(x => x.ExerciseId == exercise.ExerciseId).First(x => x.IsTarget == true);
            var targetMuscle = _context.Muscles.First(x => x.MuscleId == exerciseMuscle.MuscleId);
            var targetId = targetMuscle.MuscleId;
            var resList = new List<int>();
            foreach (var ex in exercise.ExerciseMuscles)
            {
                if (!ex.IsTarget)
                {
                    resList.Add(ex.MuscleId);
                }
            }
            exerciseSmallDescList.Add(ConvertExerciseToExerciseDesc(exercise, targetMuscle, targetId, resList));
        }

        /// <summary>
        /// Converts Exercise into ExereciseSmallDesc model.
        /// </summary>
        /// <param name="exercise">Initial exercise.</param>
        /// <param name="targetMuscle">Converted SmallDesc of exercise.</param>
        /// <param name="targetId">Specifies the id of target</param>
        /// <param name="synergists">Specified a list of synergists</param>
        /// <returns></returns>
        private ExerciseSmallDesc ConvertExerciseToExerciseDesc(Exercise exercise, Muscle targetMuscle, int targetId, List<int> synergists)
        {
            return new ExerciseSmallDesc
            {
                Id = exercise.ExerciseId,
                Image = exercise.UrlImage,
                Name = exercise.Name,
                TargetMuscle = targetMuscle.Name,
                SynergistsId = synergists,
                TargetId = targetId
            };
        }
    }
}
