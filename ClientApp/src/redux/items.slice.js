import {  createSlice } from "@reduxjs/toolkit";
import { getAllCategories , getAllItems } from "./items.action";

let initialState = {
    items:null,
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
        builder.addCase(getAllItems.pending,(state,action)=>{state.isLoading=true})
        builder.addCase(getAllItems.fulfilled,(state,action)=>{console.log("success i");state.items=action.payload;state.isLoading=false})
        builder.addCase(getAllCategories.pending,(state,action)=>{state.isLoading=true})
        builder.addCase(getAllCategories.fulfilled,(state,action)=>{console.log("success c");state.categories=action.payload;state.isLoading=false})
        builder.addDefaultCase(state=>{})
    }
})

export const actions =itemsSlice.actions
export default itemsSlice.reducer;