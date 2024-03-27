import { createAsyncThunk } from "@reduxjs/toolkit";
import axios from "axios";

export const getAllItems = createAsyncThunk(
    "item/getAllItems",
    async (a,thunkAPI)=>{
        const response = await axios.get("https://5iaf6t.realhost-free.net/api/Product/GetAll")
        try {
            return response.data.result
        }
        catch (error){
            return  thunkAPI.rejectWithValue(error)

        }
        
    }
)
export const getAllCategories = createAsyncThunk(
    "item/getAllCategories",
    async (a,thunkAPI)=>{
        const response = await axios.get("https://5iaf6t.realhost-free.net/api/Category/GetAll")
        try {
            return response.data.result
        }
        catch (error){
            return  thunkAPI.rejectWithValue(error)

        }

    }
)

