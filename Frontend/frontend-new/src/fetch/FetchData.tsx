import {IUser} from "../interfaces/IUser";
import {IRegisterUserDto} from "../interfaces/IRegisterUserDto";
import {IBasicalWorkout} from "../interfaces/IBasicalWorkout";
import {IBasicalWorkoutFull} from "../interfaces/IBasicalWorkoutFull";
import {IExerciseDesc} from "../interfaces/ExerciseById/IExerciseDesc";
import {IMuscle} from "../interfaces/IMuscle";
import {IExercise} from "../interfaces/IExercise";
import {IUsersetSmallDesc} from "../interfaces/IUsersetSmallDesc";
import {IUserSetFullDesc} from "../interfaces/IUserSetFullDesc";
import {IProfile} from "../interfaces/IProfile";
import {ITraining} from "../interfaces/ITraining";
import {IGetToken} from "../interfaces/IGetToken";
import {IAchievment} from "../interfaces/IAchievment";

const baseUrl = "https://localhost:7198/";

export const getToken = async (login: string, password: string) => {
    const response = await fetch(`${baseUrl}GetToken?login=${login}&password=${password}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});

    if (response.status === 204){
        return null;
    }
    const body = await response.json();
    const data = body as IGetToken;
    return data;
}


export const loginUser = async (token: string) => {
    const response = await fetch(`${baseUrl}Login`, {
        method: 'GET',
        headers:{
            'Authorization': 'Bearer ' + token,
            'Content-Type': 'application/x-www-form-urlencoded'
        }});

    if (response.status === 200) {
        return true;
    }
    return false
}

export const registerUser = async (user: IRegisterUserDto) => {
    const response = await fetch(`${baseUrl}User`, {
        method: 'Post',
        body: JSON.stringify({
            "login": user.login,
            "password": user.password,
            "lastName": user.lastName,
            "firstName": user.firstName
        }),
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 409){
        return false;
    }
    if (response.status === 201){
        return true;
    }
}

export const getBasicWorkoutsBySection = async (section: number) => {
    const response = await fetch(`${baseUrl}GetBySection/${section}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return null;
    }
    const body = await response.json();
    const data = body as IBasicalWorkout[];
    return data;
}

export const getBasicalWorkoutFullDesc = async (id: number) => {
    const response = await fetch(`${baseUrl}GetFullDescById/${id}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return null;
    }
    const body = await response.json();
    const data = body as IBasicalWorkoutFull;
    return data;
}

export const getExerciseDescById = async (id: number) => {
    console.log(id)
    const response = await fetch(`${baseUrl}ExerciseById/${id}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return undefined;
    }
    const body = await response.json();
    const data = body as IExerciseDesc;
    return data;
}

export const getMuscleById = async (id: number) => {
    const response = await fetch(`${baseUrl}GetMuscleById/${id}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return undefined;
    }
    const body = await response.json();
    const data = body as IMuscle;
    return data;
}

export const getAllExercises = async () => {
    const response = await fetch(`${baseUrl}AllExercises`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return undefined;
    }
    const body = await response.json();
    const data = body as IExercise[];
    return data;
}

export const getExBySearch = async (search: string) => {
    const response = await fetch(`${baseUrl}ExercisesSearch/${search}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return undefined;
    }
    const body = await response.json();
    const data = body as IExercise[];
    return data;
}

export const getExByPartBody = async (part: string) => {
    const response = await fetch(`${baseUrl}ExercisesByPartOfBody/${part}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return undefined;
    }
    const body = await response.json();
    const data = body as IExercise[];
    return data;
}

export const getMyWorkouts = async (userId: number) => {
    const response = await fetch(`${baseUrl}UserSetsByUserId/${userId}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return undefined;
    }
    const body = await response.json();
    const data = body as IUsersetSmallDesc[];
    return data;
}

export const deleteMyWorkout = async (workoutId: number) => {
    const response = await fetch(`${baseUrl}DeleteUserSet`, {
        method: 'DELETE',
        body: JSON.stringify({
            "userSetId": workoutId,
        }),
        headers: {
            'Content-Type': 'application/json',
        }});

    return response.status;
}

export const addNewWorkout = async (userId:number, name: string) => {
    const response = await fetch(`${baseUrl}CreateNewUserSetOfExercises`, {
        method: 'POST',
        body: JSON.stringify({
            "userId": userId,
            "setName": name,
        }),
        headers: {
            'Content-Type': 'application/json',
        }});

    return response.status;
}

export const addExerciseToUserSet = async (exerciseId:number, userSetId: number) => {
    const response = await fetch(`${baseUrl}AddExerciseToUserSet`, {
        method: 'POST',
        body: JSON.stringify({
            "exerciseId": exerciseId,
            "userSetId": userSetId,
        }),
        headers: {
            'Content-Type': 'application/json',
        }});

    return response.status;
}

export const getExercisesFromUserWorkout = async (userSetId: number) => {
    const response = await fetch(`${baseUrl}ExercisesByUserSet/${userSetId}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return undefined;
    }
    const body = await response.json();
    const data = body as IUserSetFullDesc;
    return data;
}

export const deleteExerciseFromWorkout = async (exerciseId:number, userSetId: number) => {
    const response = await fetch(`${baseUrl}DeleteExerciseFromUserSet`, {
        method: 'DELETE',
        body: JSON.stringify({
            "exerciseId": exerciseId,
            "userSetId": userSetId,
        }),
        headers: {
            'Content-Type': 'application/json',
        }});

    return response.status;
}

export const getProfile = async (userId: number) => {
    const response = await fetch(`${baseUrl}GetUserProfileByUserId/${userId}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return undefined;
    }
    const body = await response.json();
    const data = body as IProfile;
    return data;
}

export const getUserTrainingsByUserId = async (userId: number) => {
    const response = await fetch(`${baseUrl}GetUserTrainingsByUserId/${userId}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return undefined;
    }
    const body = await response.json();
    const data = body as ITraining[];
    return data;
}

export const getBasicTrainingsByUserId = async (userId: number) => {
    const response = await fetch(`${baseUrl}GetBasicTrainingsByUserId/${userId}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 404){
        return undefined;
    }
    const body = await response.json();
    const data = body as ITraining[];
    return data;
}

export const createAndAddBasicTraining = async (userId:number, basicalSetId: number, time: number, date: string) => {
    console.log(userId, basicalSetId, time, date)
    const response = await fetch(`${baseUrl}CreateAndAddBasicTraining`, {
        method: 'POST',
        body: JSON.stringify({
            "userId": userId,
            "basicalSetId": basicalSetId,
            "time": time,
            "date": date
        }),
        headers: {
            'Content-Type': 'application/json',
        }});

    return response.status;
}

export const createAndAddUserTraining = async (userSetId: number, time: number, date: string) => {
    const response = await fetch(`${baseUrl}CreateAndAddUserTraining`, {
        method: 'POST',
        body: JSON.stringify({
            "userSetId": userSetId,
            "time": time,
            "date": date
        }),
        headers: {
            'Content-Type': 'application/json',
        }});

    return response.status;
}

export const getAllAchievments = async (userId: number) => {
    const response = await fetch(`${baseUrl}GetAllAchievments/${userId}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json',
        }});
    if (response.status === 200){
        const body = await response.json();
        const data = body as IAchievment[];
        return data;
    }
    return undefined;
}