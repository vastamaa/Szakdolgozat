import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Books } from './components/Books';
import { Register } from './components/Register';
import { Login } from './components/Login';
import './custom.css'


export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <div className='font-face-gm'>
                <Layout className='stick-the-navbar'>
                    <Route exact path='/' component={Home} />
                    <Route path='/books' component={Books} />
                    <Route path='/account/register' component={Register} />
                    <Route path='/account/login' component={Login} />

                </Layout>

            </div>
        );
    }
}
