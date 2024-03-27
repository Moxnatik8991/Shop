import { useDispatch } from "react-redux";
import { useMemo } from "react";
import { bindActionCreators } from "@reduxjs/toolkit";
import { actions } from "../redux/items.slice";
import * as extraActions  from "../redux/items.action";

const rootActions={
    ...actions,
    ...extraActions
}

export const useActions=()=>{
    const dispatch = useDispatch()
    
    return useMemo(()=>bindActionCreators(rootActions,dispatch),[dispatch])
}