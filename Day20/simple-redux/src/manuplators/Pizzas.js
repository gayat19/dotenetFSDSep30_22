import {createSlice} from '@reduxjs/toolkit'
import { act } from 'react-dom/test-utils';

import {PizzaDetails} from '../PizzaData';

export const pizzaSlicer = createSlice({
    name:"pizzas",
    initialState:{value:PizzaDetails},
    reducers:{
        addPizza:(state,action)=>{
            state.value.push(action.payload)
        }
    }
})

export default pizzaSlicer.reducer;
export const {addPizza} =pizzaSlicer.actions;