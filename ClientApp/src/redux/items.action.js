import { createAsyncThunk } from "@reduxjs/toolkit";
import axios from "axios";

const getI=()=>{
    return  axios.get("http://localhost:2222/api/Product/GetAll")
}
const getC=()=>{
    return  axios.get("http://localhost:2222/api/Category/GetAll")
}

export const getAllItemsAndCategories = createAsyncThunk(
    "item/getAllItemsAndCategories", 
     async (arg,thunkAPI)=>{
         let result= (await Promise.all ( [getI () , getC ()] )).map(el=>el.data.result)
         
             return result;
         })

