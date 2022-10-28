import logo from './logo.svg';
import React from 'react';
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
    <div>
    <UserContext.Provider value={{username,setUsername}}>
      <div className="App">
        <div>
           The value of the counter is {counter}
          <Counter onIncrement={incrementCounter}/>
        </div>
        {/* <Welcome un={username}/> */}
        <Welcome />
        <button className='btn btn-warning' onClick={getWeather}>Get Weather Data</button>
        <AddUser onRegister={provideUsername}/>
    
        {weathers.map((weather)=>
          <WeatherComponent 
          key={Math.random()}
          wdate={weather.date}
          tc={weather.temperatureC}
          tf={weather.temperatureF}
          wsummary={weather.summary} />
        )}
      </div>
    </UserContext.Provider>
    </div>
  );
}

export default App;
