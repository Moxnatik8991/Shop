import React , { useEffect , useState } from 'react';
import st from "./TestPage.module.scss";
import { useForm } from "react-hook-form";
import { Alert , Collapse } from "@mui/material";


const TestPage = ()=>{
    let file;
    const {
        register,
        handleSubmit,
        reset,
        watch,
        formState:{errors}}=useForm()
    const onSubmit = data=>{
        console.log(file)
        debugger
    }
    const handleChange=(ev)=>{
        debugger
    }
    const [curAction,setCurAction]=useState(null)
    console.log(curAction)
    return (
        <div>
            
                <Alert severity="error">some text</Alert>
          
        </div>
    );
};

export default TestPage;