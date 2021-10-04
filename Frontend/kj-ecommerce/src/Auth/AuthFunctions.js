import React, { useContext, createContext, useState } from "react";
import {
    BrowserRouter as Router,
    Switch,
    Route,
    Link,
    Redirect,
    useHistory,
    useLocation
} from "react-router-dom";

const axios = require('axios').default;


const IdentityAuth = {
    isAuthenticated: false,
    signin(cb) {


        
        IdentityAuth.isAuthenticated = true;
        setTimeout(cb, 100); // fake async
    },
    signout(cb) {
        IdentityAuth.isAuthenticated = false;
        setTimeout(cb, 100);
    }
};

const authContext = createContext();

export function ProvideAuth({ children }) {
    const auth = useProvideAuth();
    return (
        <authContext.Provider value={auth}>
            {children}
        </authContext.Provider>
    );
}

export function useAuth() {
    return useContext(authContext);
}

function useProvideAuth() {
    const [user, setUser] = useState(null);
    const [token, setToken] = useState(null);

    const signin = (username,password,cb) => {


        return IdentityAuth.signin(() => {            

            axios.post('http://b1f6-2607-9880-16e0-cd-193-e00c-3e3b-8643.ngrok.io/identity/login',{
                "Username": username,
                "password": password
            })
            .then((response)=>{

                setUser(response.data.firstName);
                setToken(response.data.token)
                cb()
            })
            .catch(error => {
                console.log(error)
            });
            setUser('Habib');
            setToken(`eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjY3OGM5NzdmLTJiMzAtNGM4NC1hYTgxLThlODljODVlOGEyNCIsIlVzZXJOYW1lIjoiaGFiaWIiLCJuYmYiOjE2MzI3OTgwOTYsImV4cCI6MTYzMzQwMjg5NiwiaWF0IjoxNjMyNzk4MDk2fQ.FE9u9tEqSBJMJEeCFrZh7kUZcR7ysl_51Pq2w7n4hjc`)
        });
    };

    const signout = (cb) => {
        return IdentityAuth.signout(() => {
            setUser(null);
            setToken(null);
            cb();
        });
    };

    const register = (cb) => {
        return IdentityAuth.register(() => {
            
            
        });
    };

    return {
        user,
        token,
        signin,
        signout
    };
}

// A wrapper for <Route> that redirects to the login
// screen if you're not yet authenticated.
export function PrivateRoute({ children, ...rest }) {
    let auth = useAuth();


    return (
        <Route
            {...rest}
            render={({ location }) =>
                auth.user ? (children) : (
                    <Redirect
                        to={{
                            pathname: "/login",
                            state: { from: location }
                        }}
                    />
                )
            }
        />
    );
}
