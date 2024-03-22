import React from 'react';
import { useForm } from "react-hook-form";

const Home = ()=>{
    const {register,handleSubmit,formState:{errors},reset, getFieldState }=useForm({mode:"onChange"});
    errors?.text && console.log(getFieldState('text'))
   const onSubmit=(data)=>{
       console.log(data)
       reset()
   }
    return (
        <div>
            <form onSubmit={handleSubmit(onSubmit)}>
                <input {...(register ('name', 
                    { 
                            required:  "field mus be!", 
                    } )) } 
                       type="text"
                       placeholder="name"
                />
                {errors?.name && <div style={{color:"red"}}>{errors.name.message}</div>}
                <textarea {...register('text',{required:"enter text"})} placeholder="enter message" style={errors?.text? {border:"2px solid red",outline:"none"}:{border:"2px solid black",outline:"none"}}/>
                <button>Send</button>
            </form>
        </div>
    );
};

export default Home;