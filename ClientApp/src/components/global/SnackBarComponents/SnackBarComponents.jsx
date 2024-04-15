import React from "react";
import st from "./SnackBarComponents.module.scss";
import CloseIcon from "@mui/icons-material/Close";

export const AdmCatError=React.forwardRef((props,ref)=>{
    const {id,action,message}=props
   
    return(
        <div className={st.allert} ref={ref}>
            <div className={st.head}>
                Error!
                <div onClick={()=>{action.closeSnackbar(id)}}>
                    <CloseIcon/>
                </div>

            </div>
            <div className={st.message}>{ message }</div>
        </div>
    )})