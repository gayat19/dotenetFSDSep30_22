import React, { useState } from 'react';
import './AddUser.css';
import {UserContext} from '../App';
import {useContext} from 'react';

 function AddUser(props) {
    var [un,setUn]= useState('');
    var [pass,setPass]= useState('');
    const {username,setUsername} = useContext(UserContext);
    var changeUn =(event)=>{
       //console.log(event.target.value)
       setUn(event.target.value)
    }
    var changePass =(event)=>{
        setPass(event.target.value);
    }
    var registerUser =async (event)=>{
        event.preventDefault();
        // if(un=='admin' && pass=='1234')
        //     alert('registered');
        // else
        //     alert('not registered')
        var user={
            username:un,
            password:pass,
            role:'',
            status:'active'
        };
        console.log(user)
        var response = await fetch('http://localhost:5936/api/User/Register',{
            method:'POST',
            headers:{'Content-Type':'application/json'},
            body:JSON.stringify(user),
            mode:'cors'
        });
        var data = await response.json();
        console.log(data["username"]);
       // props.onRegister(data["username"])
       setUsername(data["username"])
    }
    return (
        <div className='userdiv'>
            <form onSubmit={registerUser}>
                <label className='form-control'>Username</label>
                <input className='form-control' onChange={changeUn} type="text" />
                <label className='form-control'>Password</label>
                <input className='form-control' type="password" onChange={changePass} />
                <button className='btn btn-success'>Register</button>
            </form>
        </div>
    );
}

export default AddUser;