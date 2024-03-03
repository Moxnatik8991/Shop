import { configureStore } from '@reduxjs/toolkit'
import catalogReducer from './reducerCatalog'

export default configureStore({
    reducer: {
        catalog: catalogReducer
    }
});