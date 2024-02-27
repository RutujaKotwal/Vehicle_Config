import 'bootstrap/dist/css/bootstrap.min.css'
import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import Home from './Page/Home';
import { BrowserRouter } from 'react-router-dom';
import { Route } from 'react-router-dom';
import { Routes } from 'react-router-dom';
import LoginPage from './Page/LoginPage';
import Contactus from './Page/Contactus';
import Register from './Page/Register';
import Aboutus from './Page/Aboutus';
import DefaultConfig from './Page/DefaultConfig';
import Welcome from './Page/Welcome';
import Configure from "./Page/Configure";
import Invoice from './Page/Invoice';
import DynConfig from './Page/DynConfig';

import { SelectedOptionsProvider } from './Page/SelectedOptionsContext';
const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <>
  <SelectedOptionsProvider>
    <App />
  </SelectedOptionsProvider>
  </>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
