import React from "react";
import "./CustomBucketModal.css"
import Modal from 'react-modal'
import {ReactComponent as CloseIcon} from "../../icons/Close.svg";

export const CustomBucketModal=({ isOpen,onClose,children})=>{
    
    return(
        <Modal
            isOpen={isOpen}
            ovelayClassName={"modal-overlay"}
            className={"modal-content"}
            ariaHideApp={false}
            closeTimeoutMS={300}
        >
            <button onClick={()=>onClose(false)} className={"modal-close-button"}>
                <CloseIcon />
            </button>
            {children}
        </Modal>
    )
}