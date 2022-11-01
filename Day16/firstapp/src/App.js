import logo from './logo.svg';
import React from 'react';
import {BrowserRouter as Router,Routes,Route,Link} from 'react-router-dom'

import './App.css';
import Employee from './Components/Employee';
import WeatherComponent from './Components/WeatherComponent';
import AddUser from './Components/AddUser';
import { createContext, useState, Provider } from 'react';
import Counter from './Components/Counter';
import Welcome from './Components/Welcome';



export const UserContext = React.createContext();
function App() {
 
const [weathers,setWeather] = useState([{
    date:new Date(2022,9,27),
    temperatureC:9,
    temperatureF:27,
    summary:"anything"
  }])
  const [counter,setCounter] = useState(0);
  const [username,setUsername]=useState("hello")
  
const getWeather=async ()=>{
    var response = await fetch('http://localhost:5936/WeatherForecast')
    var data = await response.json();
    setWeather(data)
}
const incrementCounter=(num)=>{
  setCounter((prevValue)=>{
    return((prevValue*1)+(num*1));
  })
}
const provideUsername=(event)=>{
  setUsername(event)
}
  return (
    <Router>
    <div>
    <UserContext.Provider value={{username,setUsername}}>
      <ul>
        <li><Link to="/" >Register</Link></li>
        <li><Link to="greet">Greet</Link></li>
      </ul>
     <Routes>
        <Route exact path="/" element={<AddUser onRegister={provideUsername}/>}></Route>
        <Route exact path="/greet" element={<Welcome un={username}/>}></Route>
        <Route exact path="/count" element={<Counter onIncrement={incrementCounter}/>}></Route>
     </Routes>
    </UserContext.Provider>
    </div>
    </Router>
  );
}

export default App;
