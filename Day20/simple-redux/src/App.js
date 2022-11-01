import logo from './logo.svg';
import './App.css';
import { useState } from 'react';
import { useSelector,useDispatch } from 'react-redux';
import {addPizza} from './manuplators/Pizzas';

function App() {
  const dispacher = useDispatch();
 const pizzaList = useSelector((state)=>state.pizzas.value);
 const [name,setName]=useState('');
 const [price,setPrice]=useState(0);
  return (
    <div className="App">
      <h1>Understanding Redux</h1>
      <div>
        <input type="text" onChange={(event)=>{setName(event.target.value)}}/>
        <input type="number" onChange={(event)=>{setPrice(event.target.value)}}/>
      <button onClick={()=>{
        dispacher(
          addPizza(
            {
              id:pizzaList.length+1,
              name:name,
              price:price
            })
            )
          }
        }>Add New Pizza</button>
      {pizzaList.map((pizza)=>{
        return(
          <div className='pizzalist'>
            <h1>
              {pizza.name}
            </h1>
            <h2> ${pizza.price}</h2>
          </div>
        )
      })}
      </div>
    </div>
  );
}

export default App;
