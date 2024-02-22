import * as React from 'react';
import { NavLink, Route, Routes, useParams, useLocation, Link } from "react-router-dom";


const Page=()=>{
    let t = useParams();
    return(
        <div>
            {"page "+t.page}  
        </div>
    )
}
export default function Home() {
    
    
    let l = useLocation();
   
    return (
       <div>
           <div>
               <NavLink  to={"page1"}>page1</NavLink>
           </div>
           <div>
               <NavLink  to={"page2"}>page2</NavLink>
           </div>
           <div>
               <Link ar to={"page3"}>page3</Link>
           </div>
           <div>
              <Routes>
                   <Route path={`:page`} element={<Page />}/>
               </Routes>
           </div>
               
       </div>
    );
}
