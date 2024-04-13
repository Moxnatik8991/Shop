import React, {
    useEffect
} from 'react';
import {
    useDispatch,
    useSelector
} from "react-redux";
import { setCatalogData } from "../../../../redux/reducerCatalog";
import axios from "axios";

import {Card} from "./Card/Card";
import styles from './styles.module.scss';
import {
    Container
} from "../../../ui/Container/Container";


export const CatalogRedux = () => {
    const catalogData = useSelector((state) => state.catalog.items);
    const dispatch = useDispatch();
    const items = catalogData.map((el, i) => <Card key={i+"_card"} data={el}/>);

    useEffect(() => {
        helper()
        }, []
    )



    function helper(){
        axios.get("http://5iaf6t.realhost-free.net/api/Product/GetAll")
            .then(response => dispatch(setCatalogData(response.data.result)))
            .catch(error => console.log(error));
    }


    return(
        <Container>
            <div className={styles.grid}>
                {items}
            </div>
        </Container>
    )
}

