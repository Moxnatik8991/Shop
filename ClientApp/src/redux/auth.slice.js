import { createSlice } from "@reduxjs/toolkit";
import { login } from "./auth.aciton";

const initialState={
    isAuth:false,
    error:null
}

export const authSlice = createSlice(
    {
        name:'auth',
        initialState,
        reducers:{
            setAuth:(state,action)=>{
                debugger
                state.isAuth = action.payload
            },
            removeError:(state)=>{
                state.error = null
            }
        },
        extraReducers: builder=>{
            
            builder.addCase(login.fulfilled,(state,action)=>{
                
                state.isAuth = true;
                localStorage.setItem("token",action.payload?.accessToken)
            })
            builder.addCase(login.rejected,(state,action)=>{
                state.error = action.payload
            })
            builder.addDefaultCase(state=>state)
        }
        
        
    }
)
export const {setAuth,removeError} = authSlice.actions;
export default authSlice.reducer;
