import React, { useRef, useState } from 'react';
import { Container, Row, Col } from 'react-bootstrap';
import Navbar_tool from '../component/Navbar_tool';
import './Aboutus.css'; // Import CSS file


const Aboutus = () => {
  const historyRef = useRef(null);
  const financialResultsRef = useRef(null);
  const managementRef = useRef(null);
  const officesRef = useRef(null);

  const [showHistoryDropdown, setShowHistoryDropdown] = useState(false);
  const [showFinancialResultsDropdown, setShowFinancialResultsDropdown] = useState(false);
  const [showManagementDropdown, setShowManagementDropdown] = useState(false);
  const [showOfficesDropdown, setShowOfficesDropdown] = useState(false);

  const scrollToRef = (ref) => {
    window.scrollTo({
      top: ref.current.offsetTop,
      behavior: 'smooth'
    });
  };

  return (
    <div>
      <div className="main-content">
        <div className="about-us">
          <h1>About Us</h1>
          <p>Welcome to our site! Here's some information about us:</p>
        </div>

        <Container>
          <Row className="mt-5">
            <Col 
              onMouseEnter={() => setShowHistoryDropdown(true)} 
              onMouseLeave={() => setShowHistoryDropdown(false)}
              onClick={() => scrollToRef(historyRef)} 
              style={{cursor: 'pointer'}}
            >
              <h2>History</h2>
              {showHistoryDropdown && (
                <div className="dropdown-content">
                  <p>Insert detailed history information here...</p>
                </div>
              )}
            </Col>
          </Row>

          <Row className="mt-5">
            <Col 
              onMouseEnter={() => setShowFinancialResultsDropdown(true)} 
              onMouseLeave={() => setShowFinancialResultsDropdown(false)}
              onClick={() => scrollToRef(financialResultsRef)} 
              style={{cursor: 'pointer'}}
            >
              <h2>Financial Results</h2>
              {showFinancialResultsDropdown && (
                <div className="dropdown-content">
                  <p>Insert detailed financial results information here...</p>
                </div>
              )}
            </Col>
          </Row>

          <Row className="mt-5">
            <Col 
              onMouseEnter={() => setShowManagementDropdown(true)} 
              onMouseLeave={() => setShowManagementDropdown(false)}
              onClick={() => scrollToRef(managementRef)} 
              style={{cursor: 'pointer'}}
            >
              <h2>Management</h2>
              {showManagementDropdown && (
                <div className="dropdown-content">
                  <p>Insert detailed management information here...</p>
                </div>
              )}
            </Col>
          </Row>

          <Row className="mt-5">
            <Col 
              onMouseEnter={() => setShowOfficesDropdown(true)} 
              onMouseLeave={() => setShowOfficesDropdown(false)}
              onClick={() => scrollToRef(officesRef)} 
              style={{cursor: 'pointer'}}
            >
              <h2>Offices</h2>
              {showOfficesDropdown && (
                <div className="dropdown-content">
                  <p>Insert detailed offices information here...</p>
                </div>
              )}
            </Col>
          </Row>
        </Container>
      </div>
      
      <div ref={historyRef}></div>
      <div ref={financialResultsRef}></div>
      <div ref={managementRef}></div>
      <div ref={officesRef}></div>
    </div>
  );
}

export default Aboutus;