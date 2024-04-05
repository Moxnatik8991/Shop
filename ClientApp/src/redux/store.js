import { configureStore } from '@reduxjs/toolkit'
import catalogReducer from './reducerCatalog'
import reducer from './items.slice'
import auth from './auth.slice'
export default configureStore({
    reducer: {
        catalog: catalogReducer,
        item: reducer,
        auth: auth
    },
    devTools:true
});