using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Infrastructure.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Achievment",
                columns: new[] { "AchievmentId", "Description", "Name", "UrlImage" },
                values: new object[,]
                {
                    { 1, "Finish Your First Training Session", "First Steps", "https://cdn-icons-png.flaticon.com/512/7173/7173358.png" },
                    { 2, "Finish 10 Training Sessions", "On The Right Way", "https://www.k2ksigns.com.au/cdn/shop/products/TRS45-PedestrianRightway_1200x1200.jpg?v=1681423354" },
                    { 3, "Finish 50 Training Sessions", "You Got Better", "https://png.pngtree.com/png-vector/20240805/ourlarge/pngtree-retro-distressed-sticker-of-a-cartoon-burning-direction-arrow-png-image_13088695.png" },
                    { 4, "Finish 5 Basical Training Sessions", "Learn From The Best", "https://thumbs.dreamstime.com/b/strong-arm-showing-biceps-muscle-strong-arm-showing-its-biceps-muscle-illustration-134575504.jpg" },
                    { 5, "Finish 5 Your Own Trainings", "Train On Your Own", "https://images.emojiterra.com/google/noto-emoji/unicode-15.1/color/1024px/1f60e.png" },
                    { 6, "Create your first custom workout plan", "Creator", "https://images.emojiterra.com/twitter/v13.1/512px/1f5d2.png" },
                    { 7, "Explore 5 different workout plans", "Researcher", "https://cdn1.iconfinder.com/data/icons/smashicons-emoticons-retro-vol-1/60/37_-_Explorer_emoticon_emoji_face-512.png" }
                });

            migrationBuilder.InsertData(
                table: "BasicalSetEfficiency",
                columns: new[] { "EfficiencyId", "Abs", "Arms", "Back", "BasicalSetId", "Cardio", "Chest", "Legs" },
                values: new object[,]
                {
                    { 1, 4, 2, 3, 0, 5, 2, 3 },
                    { 2, 3, 1, 4, 0, 4, 0, 5 },
                    { 3, 2, 5, 4, 0, 2, 5, 1 },
                    { 4, 5, 0, 3, 0, 0, 0, 5 },
                    { 5, 2, 2, 5, 0, 3, 4, 4 },
                    { 6, 4, 3, 0, 0, 5, 2, 0 },
                    { 7, 3, 4, 4, 0, 2, 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "ExerciseId", "Description", "Name", "UrlImage", "UrlVideo" },
                values: new object[,]
                {
                    { 1, "A basic upper body exercise targeting the pectoral muscles, triceps, and shoulders.", "Barbell Bench Press", "https://cdn.muscleandstrength.com/sites/default/files/barbell-bench-press_0.jpg", "https://www.youtube.com/watch?v=rT7DgCr-3pg" },
                    { 2, "An isolation exercise focusing on the biceps for strength and size.", "Bicep Curl", "https://www.verywellfit.com/thmb/plk9oJP3KcuRnBaq8bk3sGrsVjM=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/81-3498604-Bicep-arm-curlsGIF2-c7c59f252b1a4ef9b1e181ca05e96084.jpg", "https://www.youtube.com/watch?v=ykJmrZ5v0Oo" },
                    { 3, "A compound exercise primarily working the quadriceps, hamstrings, and glutes.", "Squat", "https://res.cloudinary.com/peloton-cycle/image/fetch/f_auto,c_limit,w_3840,q_90/https://downloads.ctfassets.net/6ilvqec50fal/1EHc7nNZ4VqgTjyKoNnyvd/08a03edafa59cf2f74b591765cc68c62/Barbell-squat.jpg", "https://www.youtube.com/watch?v=xqvCmoLULNY" }
                });

            migrationBuilder.InsertData(
                table: "Muscle",
                columns: new[] { "MuscleId", "Description", "Name", "PartOfBody", "UrlImage" },
                values: new object[,]
                {
                    { 1, "A muscle of the upper arm that acts to flex the elbow and supinate the forearm.", "Biceps Brachii", "Upper Arms", "https://www.kenhub.com/thumbor/0X8VRKFTJ5DT-6OaYklyFn42-xY=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/14480/biceps_intro.png" },
                    { 2, "A large muscle on the back of the upper arm, responsible for extending the elbow.", "Triceps Brachii", "Upper Arms", "https://www.kenhub.com/thumbor/HFbTJc2AayYsrOSJMmDE5axXPvs=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/13946/aHliOOl62koJhumoZcUysg_vsBTp2iDc2_M._triceps_brachii_1.png" },
                    { 3, "A thick, fan-shaped muscle situated at the chest of the body, responsible for moving the arm.", "Pectoralis Major", "Chest", "https://www.kenhub.com/thumbor/rd8CbMjXA6gntGs93sl8EYIc6lI=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/13535/Wt6B7qUeKq5WqFGlzsQ_Musculus_pectoralis_major_01.png" },
                    { 4, "A paired muscle running vertically on each side of the anterior wall of the human abdomen.", "Rectus Abdominis", "Waist", "https://www.kenhub.com/thumbor/FyEucwQsZ4Kbhs4iErFa4jQplIc=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/article/rectus-abdominis-muscle/wwCbmBxMstOsHbXlWiA_jt6lkyuTYizDZFWnsiHpng_Musculus_rectus_abdominis_01.png" },
                    { 5, "A triangular muscle covering the shoulder joint and responsible for arm rotation.", "Deltoid", "Shoulders", "https://www.kenhub.com/thumbor/Si1vuP8MMgFOchicWEn_Vt4qzX0=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/13537/ZjXqXLfFvjRqzu4Ue14DA_degvezVumJ_M._deltoideus_2.png" },
                    { 6, "A large group of muscles located at the front of the thigh, responsible for extending the knee.", "Quadriceps", "Thighs", "https://www.kenhub.com/thumbor/08O0Lk96jBOozWw5dFgEB1G6MaM=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/13926/Op0rOgXqQB5W7THiS8Q_NmqapCoy4Z_M._quadriceps_femoris_NN_2__1_.png" },
                    { 7, "A group of muscles at the back of the thigh that work to flex the knee and extend the hip.", "Hamstrings", "Thighs", "https://www.kenhub.com/thumbor/0qdCfYj-eciZ64ynl_7cdsQz4KU=/fit-in/800x1600/filters:watermark(/images/logo_url.png,-10,-10,0):background_color(FFFFFF):format(jpeg)/images/library/14013/Hamstring_muscles.png" }
                });

            migrationBuilder.InsertData(
                table: "BasicalSetOfExercises",
                columns: new[] { "BasicalSetId", "Description", "Name", "Section", "UrlImage" },
                values: new object[,]
                {
                    { 1, "A workout plan designed to target all major muscle groups for mass gain.", "Full Body Mass Gain", 1, "https://www.dmoose.com/cdn/shop/articles/feature-image_8fe9c007-78d4-4a6e-b08c-20692f4b84b0.jpg?v=1682514044" },
                    { 2, "An upper body workout focused on bulking up your chest, shoulders, and arms.", "Upper Body Bulk", 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQPdPHrTAb2xqkDfT7DMtU-2ddq8WBsTjZ-Pw&s" },
                    { 3, "A high-intensity circuit workout for fat loss, combining cardio with strength exercises.", "Fat Blasting Circuit", 2, "https://skinnyms.com/wp-content/uploads/2016/05/5-Calorie-Crushing-No-Equipment-Exercises.jpg" },
                    { 4, "A workout focused on sculpting your legs and abs, aimed at fat loss.", "Legs and Abs Shred", 2, "https://hips.hearstapps.com/hmg-prod/images/gym-instructer-doing-lunges-with-kettlebells-royalty-free-image-1585227849.jpg" },
                    { 5, "A high-intensity workout used by professional athletes to build overall strength.", "Pro Athlete Strength Training", 3, "https://www.pogophysio.com.au/wp-content/uploads/weights-cody-blog.jpg" },
                    { 6, "An explosive workout routine focused on improving power and agility, used by elite athletes.", "Explosive Power Routine", 3, "https://educatefitness.co.uk/wp-content/uploads/2023/04/Incorporate-Explosive-Training-into-Your-Routine.webp" }
                });

            migrationBuilder.InsertData(
                table: "ExerciseMuscles",
                columns: new[] { "Id", "ExerciseId", "IsTarget", "MuscleId" },
                values: new object[,]
                {
                    { 1, 1, true, 3 },
                    { 2, 1, false, 2 },
                    { 3, 1, false, 5 },
                    { 4, 2, true, 1 },
                    { 5, 2, false, 5 },
                    { 6, 3, true, 4 },
                    { 7, 3, false, 5 }
                });

            migrationBuilder.InsertData(
                table: "BasicalSetExercise",
                columns: new[] { "Id", "BasicalSetId", "ExerciseId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 3 },
                    { 3, 2, 1 },
                    { 4, 2, 2 },
                    { 5, 3, 1 },
                    { 6, 3, 3 },
                    { 7, 4, 3 },
                    { 8, 5, 1 },
                    { 9, 5, 3 },
                    { 10, 6, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievment",
                keyColumn: "AchievmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Achievment",
                keyColumn: "AchievmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Achievment",
                keyColumn: "AchievmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Achievment",
                keyColumn: "AchievmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Achievment",
                keyColumn: "AchievmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Achievment",
                keyColumn: "AchievmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Achievment",
                keyColumn: "AchievmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BasicalSetExercise",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BasicalSetExercise",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BasicalSetExercise",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BasicalSetExercise",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BasicalSetExercise",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BasicalSetExercise",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BasicalSetExercise",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BasicalSetExercise",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BasicalSetExercise",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BasicalSetExercise",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExerciseMuscles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Muscle",
                keyColumn: "MuscleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Muscle",
                keyColumn: "MuscleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BasicalSetOfExercises",
                keyColumn: "BasicalSetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BasicalSetOfExercises",
                keyColumn: "BasicalSetId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BasicalSetOfExercises",
                keyColumn: "BasicalSetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BasicalSetOfExercises",
                keyColumn: "BasicalSetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BasicalSetOfExercises",
                keyColumn: "BasicalSetId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BasicalSetOfExercises",
                keyColumn: "BasicalSetId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ExerciseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ExerciseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercise",
                keyColumn: "ExerciseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Muscle",
                keyColumn: "MuscleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Muscle",
                keyColumn: "MuscleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Muscle",
                keyColumn: "MuscleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Muscle",
                keyColumn: "MuscleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Muscle",
                keyColumn: "MuscleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BasicalSetEfficiency",
                keyColumn: "EfficiencyId",
                keyValue: 6);
        }
    }
}
