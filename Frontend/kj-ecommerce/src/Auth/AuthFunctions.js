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

const IdentityAuth = {
    isAuthenticated: false,
    signin(cb) {

        // get token


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

    const signin = cb => {
        return IdentityAuth.signin(() => {
            setUser("user");
            setToken('123')
            cb();
        });
    };

    const signout = cb => {
        return IdentityAuth.signout(() => {
            setUser(null);
            setToken(null);
            cb();
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

    console.log('inside private route, auth.token',auth.token)
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
