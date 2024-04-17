import { createAsyncThunk } from "@reduxjs/toolkit";
import axios from "axios";

const getI=()=>{
    return axios.get("https://5iaf6t.realhost-free.net/api/Product/GetAll")
}
const getC=()=>{
    return axios.get("https://5iaf6t.realhost-free.net/api/Category/GetAll")
}

export const getAllItemsAndCategories = createAsyncThunk(
    "item/getAllItemsAndCategories", 
     async (arg,thunkAPI)=>{
         let result= (await Promise.all ( [getI () , getC ()] )).map(el=>el.data.result)
         
             return result;
         })

