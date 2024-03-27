import {  createSlice } from "@reduxjs/toolkit";
import { getAllCategories , getAllItems } from "./items.action";

let initialState = {
    items:[],
    categories:null,
    isLoading: false,
    error: null,
    result:1
}

export const itemsSlice = createSlice({
    name:"item",
    initialState: initialState,
    reducers:{
    },
    extraReducers: builder=>{
        builder.addCase(getAllItems.fulfilled,(state,action)=>{console.log("success i");state.items=action.payload})
        builder.addCase(getAllCategories.fulfilled,(state,action)=>{console.log("success c");state.categories=action.payload})
        builder.addDefaultCase(state=>{})
    }
})

export const actions =itemsSlice.actions
export default itemsSlice.reducer;