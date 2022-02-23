import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Counter } from './components/Counter';
import { FetchBooks } from './components/FetchBooks';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <div className='font-face-gm'>
        <Layout>
          <Route exact path='/' component={Home} />
          <Route path='/counter' component={Counter} />
          <Route path='/fetch-books' component={FetchBooks} />
        </Layout>
      </div>
    );
  }
}
