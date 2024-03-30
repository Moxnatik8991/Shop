import {  createSlice } from "@reduxjs/toolkit";
import { getAllItemsAndCategories } from "./items.action";

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
        builder.addCase(getAllItemsAndCategories.pending,
                state=>{state.isLoading=true})
        builder.addCase(getAllItemsAndCategories.fulfilled,
            (state,action)=>{
            console.log("success get all items and categories");
            state.items=action.payload[0];
            state.categories=action.payload[1];
            state.isLoading = false })
        builder.addDefaultCase(state=>{})
    }
})

export const actions =itemsSlice.actions
export default itemsSlice.reducer;