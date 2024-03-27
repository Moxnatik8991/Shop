import { configureStore } from '@reduxjs/toolkit'
import catalogReducer from './reducerCatalog'
import reducer from './items.slice'
export default configureStore({
    reducer: {
        /*catalog: catalogReducer,*/
        item: reducer
    },
    devTools:true
});