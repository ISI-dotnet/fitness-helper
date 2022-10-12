﻿using Backend.Core.Interfaces;
using Backend.Core.Models.Profile;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;
        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        [Route("/Profile/{userId}")]
        public ActionResult<UserProfile> Profile(int userId)
        {
            var profile = _profileService.GetUserProfileByUserId(userId);
            if (profile == null)
                return NoContent();
            return Ok(profile);
        }

        [HttpGet]
        [Route("/UserTrainings/{userId}")]
        public ActionResult<List<TrainingDesc>> UserTrainings(int userId)
        {
            var trainings = _profileService.GetUserTrainingsByUserId(userId);
            if (trainings == null)
                return BadRequest();
            return Ok(trainings);
        }

        [HttpGet]
        [Route("/BasicTrainings/{userId}")]
        public ActionResult<List<TrainingDesc>> BasicTrainings(int userId)
        {
            var trainings = _profileService.GetBasicTrainingsByUserId(userId);
            if (trainings == null)
                return BadRequest();
            return Ok(trainings);
        }
    }
}
