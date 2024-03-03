import { createSlice } from '@reduxjs/toolkit'

export const catalogSlice = createSlice({
    name: 'catalog',
    initialState: {
        items: [
            {
                name: 'Name',
                description: 'Description',
                price: 0.00,
                categoryId: 'ctegoryIdHash',
                userId: 'userIdHash',
                id: 'idHash',
                dataCreate: 'date',
                dataUpdate: 'date'
            },
        ]
    },
    reducers: {
        setCatalogData: (state, action) => {
            state.items = action.payload
        }
    }
});

export const {setCatalogData} = catalogSlice.actions;
export default catalogSlice.reducer;