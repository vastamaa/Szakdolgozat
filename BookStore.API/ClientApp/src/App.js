import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Books } from './components/Books';
import { Register } from './components/Register';
import { Login } from './components/Login';
import { Profile } from './components/Profile';
import { ForgotPassword } from './components/ForgotPassword';
import { Cart } from './components/Cart';
import './custom.css'


export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <div className='font-face-gm'>
                <Layout className='stick-the-navbar'>
                    <Route exact path='/' component={Home} />
                    <Route path='/books' component={Books} />
                    <Route path='/accounts/register' component={Register} />
                    <Route path='/accounts/login' component={Login} />
                    <Route path='/accounts/profile-page' component={Profile} />
                    <Route path='/accounts/forgot-password' component={ForgotPassword} />
                    <Route path='/cart' component={Cart}/>
                </Layout>
            </div>
        );
    }
}