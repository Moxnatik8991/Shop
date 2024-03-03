import React from 'react';
import styles from './card.module.scss'

export const Card = (props) => {
    return(
        <div className={styles.card}>
            <div className={styles.name}> {props.data.name}</div>
            <div className={styles.description}>{props.data.description}</div>
            <div className={styles.price}>{props.data.price}</div>
        </div>
    )
}