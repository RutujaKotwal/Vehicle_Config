import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Container, Row, Col } from 'react-bootstrap';
import { Routes, Route, useLocation, Outlet } from 'react-router-dom';
import './App.css';
import Home from './Page/Home';
import { BrowserRouter } from 'react-router-dom';
import LoginPage from './Page/LoginPage';
import Contactus from './Page/Contactus';
import Register from './Page/Register';
import Aboutus from './Page/Aboutus';
import DefaultConfig from './Page/DefaultConfig';
import Welcome from './Page/Welcome';
import Configure from "./Page/Configure";
import Invoice from './Page/Invoice';
import Navbar_tool from './component/Navbar_tool';
import Header from './component/Header';
import Footer from './component/Footer';
import DynConfig from './Page/DynConfig';



function App() {

 
  return (
    <div className="App">
      <BrowserRouter>
      <Header/>
      <Navbar_tool/>
    <Routes>
      <Route path ="/" exact element ={<Home />}></Route>
      <Route path ="/Aboutus" exact element ={<Aboutus />}></Route>
      <Route path ="/Register" exact element ={<Register />}></Route>
      <Route path ="/Contactus" exact element ={<Contactus />}></Route>
      {/* <Route path ="/feedback" exact element ={<Feedback />}></Route>
       */}
      <Route path ="/dynconfig" exact element ={<DynConfig />}></Route>
      <Route path ="/Welcome" exact element ={<Welcome />}></Route>
      <Route path ="/LoginPage" exact element ={<LoginPage />}></Route>
      <Route path ="/DefaultConfig/:Model_id" exact element ={<DefaultConfig />}></Route>
      <Route path ="/Configure" exact element ={<Configure />}></Route>
      <Route path ="/Invoice" exact element ={<Invoice />}></Route>
    </Routes>
    </BrowserRouter>
      <Footer/>
    </div>
  );
}

export default App;