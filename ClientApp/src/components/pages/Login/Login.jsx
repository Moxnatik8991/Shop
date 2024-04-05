import React , { useEffect , useState } from 'react';
import LoginModal from "../../global/CustomModals/LoginModal";
import { useSelector } from "react-redux";

const Login = ()=>{
    
    const {isAuth}=useSelector(state=>state.auth)
    const [loginModalOpen,setLoginModalOpen]=useState(false);
    useEffect ( ()=>{
        if(isAuth&& loginModalOpen) setLoginModalOpen(false)
    } , [isAuth] );
    return (
        <div>
            <button   onClick={()=>{setLoginModalOpen(true)}}>show login modal</button>
            {isAuth?<div>Welcome, Admin!</div>:<div>Need authorize!</div>}
            <LoginModal isOpen={loginModalOpen} onClose={()=>{setLoginModalOpen(false)}}/>
        </div>
    );
};

export default Login;