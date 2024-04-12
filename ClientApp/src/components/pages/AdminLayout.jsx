import React from 'react';
import st from './AdminLayout.module.scss'
import CategoryRoundedIcon from '@mui/icons-material/CategoryRounded';
import DialpadOutlinedIcon from '@mui/icons-material/DialpadOutlined';
import GroupOutlinedIcon from '@mui/icons-material/GroupOutlined';
import GradingOutlinedIcon from '@mui/icons-material/GradingOutlined';
import AdminCategories from "./AdminCategories/AdminCategories";
const AdminLayout = ()=>{
    return (
        <>
            <div className={st.container}>
                <div className={st.navMenu}>
                    <div className={st.name}>
                        Welcome <br/> Admin
                    </div>
                    <div className={ st.items }>
                        <div>
                            <CategoryRoundedIcon fontSize='medium'/>
                            Categories
                        </div>
                        <div>
                            <DialpadOutlinedIcon fontSize='medium'/>
                            Items
                        </div>
                        <div>
                            <GroupOutlinedIcon fontSize='medium'/>
                            Users
                        </div>
                        <div>
                            <GradingOutlinedIcon fontSize='medium'/>
                            Orders
                        </div>

                    </div>
                </div>
                <div className={ st.contentBlock }>
                    <div className={st.name}>
                        Welcome to your own admin panel! Here you could do anything!)
                    </div>
                    <div className={st.content}>
                        <AdminCategories/>
                    </div>
                </div>
            </div>
        </>
    );
};

export default AdminLayout;