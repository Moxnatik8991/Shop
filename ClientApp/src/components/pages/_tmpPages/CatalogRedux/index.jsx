import React, {
    useEffect
} from 'react';
import {
    useDispatch,
    useSelector
} from "react-redux";
import { getCatalog } from "../../../../redux/reducerCatalog";

export const CatalogRedux = () => {
    const catalogData = useSelector((state) => state.catalog.items);
    const dispatch = useDispatch();
    let items;

    const data = [
        {test: 1},
        {test: 2}
    ]

    useEffect(() => {
        dispatch(getCatalog(data));
        // items = catalogData.payload.map(el => <div>{el.test}</div>)
        }, []
    )


    return(
        <div>
            Catalog with Redux
            <div>
                {items}
            </div>
        </div>
    )
}