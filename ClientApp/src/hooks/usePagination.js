import { Pagination } from "@mui/material";
import React , { useState } from "react";


 export const usePagination=()=>{

    const [pagination,setPagination]=useState(null)
    const [page,setPage]=useState(1)
    const handleChange=(e,value)=>{
        setPage(value)
    }
    let paginationEl = <Pagination  onChange={handleChange}  count={pagination?pagination.totalPages:10} />
    
    return {page,setPagination,paginationEl}
    
}