import React , { useEffect } from 'react';
import Modal from "react-modal";
import st from './LoginModal.module.scss'
import { useDispatch , useSelector } from "react-redux";
import { removeError  } from "../../../redux/auth.slice";
import { useForm } from "react-hook-form";
import { login } from "../../../redux/auth.aciton";
import girl from './../../../icons/girl2.png'

const LoginModal = ({isOpen,onClose})=>{
    const dispatch = useDispatch();
    const {isAuth,error}=useSelector(state=>state.auth)
 
    const {register,handleSubmit,
        formState:{errors}, reset}=useForm({mode:"onChange"})
    const onSubmit=data=>{
        let sendData= {
            email:data.login,
            password:data.password
        }
        dispatch(login(sendData))
        reset();
    }
    const removeErr=()=>{
       dispatch(removeError()) 
    }
    return (
        <Modal 
            isOpen={isOpen} 
            overlayClassName={st.overlay} 
            className={st.content} 
            ariaHideApp={false}
            closeTimeoutMS={300}
            onRequestClose={()=>onClose()}
        >
            <button className={st.closeButton} onClick={()=>{onClose();reset();dispatch(removeError()) }}>Close</button>
            <div className={st.contentWrap}>
                <div className={st.imageBl}>
                    <img src={ girl } alt=""/>
                </div>
                <div className={ st.formBl }>
                    { isAuth
                        ? <div className={st.authorized}>
                            <p>You are already authorized!</p>
                            <img src="https://media1.giphy.com/media/v1.Y2lkPTc5MGI3NjExcjd6cnRlOGJrNWd2NmZ2dGJpZG55c3U0ODR1eDlraHYwMDhhaWc0dCZlcD12MV9pbnRlcm5hbF9naWZfYnlfaWQmY3Q9cw/02iB5X78Zrr3Xg7K4n/giphy.gif" alt=""/>
                    </div>
                        : <form onSubmit={ handleSubmit ( onSubmit ) }>
                            <div>
                                <div className={ st.login }>
                                    { error && <div className={ st.error }>{ error }</div> }
                                    <div>Login</div>
                                    <input { ...register (
                                        'login' ,
                                        {
                                            required : "Login is necessary!" ,
                                            pattern : {
                                                value : /^((([0-9A-Za-z]{1}[-0-9A-z\.]{1,}[0-9A-Za-z]{1})|([0-9А-Яа-я]{1}[-0-9А-я\.]{1,}[0-9А-Яа-я]{1}))@([-A-Za-z]{1,}\.){1,2}[-A-Za-z]{2,})$/u ,
                                                message : "Email is not correct!"
                                            }
                                        }
                                    ) }
                                           type="text"
                                           placeholder="Enter your login..."
                                           className={ errors?.login ? st.inputError : st.normalInput }
                                           onClick={ removeErr }
                                    />

                                </div>
                                { errors?.login && <span>{ errors.login.message }</span> }
                            </div>
                            <div>
                                <div className={ st.login }>
                                    <div className={ st.login }>
                                        <div>Password</div>
                                        <input { ...register (
                                            'password' ,
                                            {
                                                required : "Password is necessary!"
                                            }
                                        ) }
                                               type="password"
                                               placeholder="Enter your password..."
                                               className={ errors?.password ? st.inputError : st.normalInput }
                                               onClick={ removeErr }
                                        />
                                    </div>
                                    { errors?.password && <span>{ errors.password.message }</span> }
                                </div>
                            </div>
                            <button className={ st.loginButton }>Login</button>
                        </form>
                    }
                    
                </div>
            </div>
        </Modal>
    );
};

export default LoginModal;