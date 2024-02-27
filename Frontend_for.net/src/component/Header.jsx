import React from 'react';
import { Container, Row, Col } from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import './Header.css';
import Home from '../Page/Home';
import logo from './Nexcar.jpg';// Import Nexcar from the correct path
import { useNavigate } from 'react-router-dom';

function Header() {
  let navigate = useNavigate();
  const handleclick =(event)=>{
    navigate(`/`);
  }
  return (
    <Container fluid className='header-container headerStyle'>
      <Row className="align-items-center">
        <Col xs={12} sm={6} md={4} className="d-flex justify-content-center justify-content-md-start">
          <img src={logo} alt="Company Logo" className="logo" style={{ margin: 0, padding: 0 }} onClick={handleclick}/>
        </Col>
        <Col xs={12} sm={6} md={4} className="text-center text-sm-start d-flex align-items-center justify-content-center">
          <h1 className="header-h1" style={{ margin: 0, padding: 0 }}>NEXCAR</h1>
        </Col>
      </Row>
    </Container>
  );
}

export default Header;
