import React , { useEffect , useRef , useState } from 'react';
import st from "./AdminCategories.module.scss";
import { useForm } from "react-hook-form";
import noImage from '../../../icons/no-photos.png'
import { ApiCategory } from "../../../https";
import { Collapse } from "@mui/material";

const Forms = ({curCat,curAction,setRequest})=>{
    const {
        register,
        handleSubmit,
        reset, setValue,
        formState:{errors, }}=useForm({mode:"onChange"})
    const submitCreate = data=>{
        const formData = new FormData();
        formData.append('Name',data.name)
        formData.append('CategoryId',data.categoryId)
        formData.append('File',data.file[0])
        ApiCategory.addNew(formData).then(res=>{if(res){alert("Add success!");setRequest(prevState=>!prevState)}})
    }
    const submitUpdate = data=>{
        debugger
        const formData = new FormData();
        formData.append('Name',data.name)
        formData.append('CategoryId',data.categoryId)
        formData.append('File',data.file[0])
        ApiCategory.change(data.Id,formData).then(res=>{
            debugger
            if(res.isSuccess){
                alert("Update success");
                setRequest(prevState=>!prevState )
            }
            if(!res.isSuccess){
                alert(res.ErrorMessage);
            }
        })
    }
    const submitDelete = data=>{
     debugger   
        ApiCategory.delete(data.Id).then(res=>{
            debugger
            if(res.isSuccess){
                alert("delete success");
                setRequest(prevState=>!prevState )
            }
            if(!res.isSuccess){
                alert(res.ErrorMessage);
            }
        })
    }
    
    const [files,setFiles]=useState()
    const [prew,setPrew]=useState()
    useEffect ( ()=>{
        if(!files) setPrew(null)
        if(files)setPrew(URL.createObjectURL(files))
    } , [files] );
    
    useEffect ( ()=>{
        if(!curAction) return
        if(curAction === 'create') {
            setValue('name',curCat?.name)
            setValue('categoryId',curCat?.id)
        }
        if(curAction === 'update')  {
            setValue('name',curCat?.name)
            setValue('categoryId',curCat?.categoryId)
            setValue('Id',curCat?.id)
        }
        if(curAction === 'delete') {
            setValue('Id',curCat?.id)
        }
        
        
    } , [curCat,curAction] );
    const createUpdate = curAction === 'create'||curAction === 'update'
    const updateDelete = curAction === 'delete'||curAction === 'update'
    
    return (
        
        <div style={{paddingTop:'30px'}}>
             <form>
                
                {createUpdate && 
                    <div>
                    <span>Name: </span>
                    <input { ...register (
                        'name' ,
                        {
                            required : "This field couldn't be blank!"
                        }
                    ) }
                           type="text"
                           className={ errors?.name ? st.errInp : null }/>
                    { errors?.name && <span className={ st.errorMes }>{ errors.name.message }</span> }
                </div> 
                }
                {createUpdate &&
                    <div>
                        
                    <span>CategoryId: </span>
                    <input { ...register ( 'categoryId' ) }
                           type="text"
                           className={ errors?.categoryId ? st.errInp : null }/>
                    { errors?.categoryId && <span className={ st.errorMes }>{ errors.categoryId.message }</span> }
                </div>
                }
                {updateDelete && 
                    <div>
                    <span>Id: </span>
                    <input { ...register (
                        'Id',
                        {
                            required : "This field couldn't be blank!"
                        }
                    ) }
                           type="text"
                           className={ errors?.categoryId ? st.errInp : null }/>
                    { errors?.Id && <span className={ st.errorMes }>{ errors.Id.message }</span> }
                </div>
                }
                {createUpdate &&
                    <div className={ st.fileInp }>
                    <span>Image: </span>
                    <label className={ st.fileLabel }>
                        Загрузить
                        <input { ...register ( 'file' ) }
                               type="file" onChange={ (e)=>{
                            setFiles ( e.target.files[0] )
                        } }/>
                    </label>
                    <img src={ prew ? prew : noImage } alt=""/>
                </div>
                }
                 { curAction === 'create'&& <button onClick={handleSubmit(submitCreate)}>submit</button>}
                 { curAction === 'update'&& <button onClick={handleSubmit(submitUpdate)}>submit</button>}
                 { curAction === 'delete'&& <button onClick={handleSubmit(submitDelete)}>submit</button>}
            </form>
        </div>
    );
};

export default Forms;