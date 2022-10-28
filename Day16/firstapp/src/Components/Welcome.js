import React from 'react';
import {UserContext} from '../App';
import {useContext} from 'react';

function Welcome(props) {
    const {username} = useContext(UserContext);
    return (
        <div>
            Welcome {username}
        </div>
    );
}

export default Welcome;