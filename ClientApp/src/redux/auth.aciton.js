import { createAsyncThunk } from "@reduxjs/toolkit";
import $api from "../https";


export const login = createAsyncThunk(
    'auth/login',
    async ({email,password},thunkAPI)=>{
        debugger
        try {
            const response =   await $api.post('/Login',{email,password})
            return response.data.result
        }
        catch (err){
            debugger
           return thunkAPI.rejectWithValue(err.response?.data?.ErrorMessage)
        }
    }
)