import React from 'react';
import { Link } from 'react-router-dom';
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import { useSelectedOptions } from '../Page/SelectedOptionsContext';
import { useNavigate } from 'react-router-dom';
import './navcls.css'; // Import CSS file

function Navbar_tool() {
    let navigate = useNavigate();
    const { isAuthenticated, setauthentication } = useSelectedOptions();
    const handleLogout = () => {
        sessionStorage.removeItem("userinfo");
        setauthentication(false);
        navigate("/LoginPage");
    };
    return (
        <Navbar className='navcls'>
            <Container>
                <Nav className="me-auto">
                    <Nav.Link as={Link} to="/Aboutus" className="txt">About us</Nav.Link>
                    <Nav.Link as={Link} to="/Contactus" className="txt">Contact us</Nav.Link>
                </Nav>
                <Nav>
                    {!isAuthenticated && !sessionStorage.getItem("userinfo") ? (
                        <li className="login-button">
                            <Nav.Link as={Link} to="/LoginPage" className="txt">Login</Nav.Link>
                        </li>
                    ) : (
                        <li className="login-button">
                            <Nav.Link onClick={handleLogout} className="txt">Logout</Nav.Link>
                        </li>
                    )}
                    <Nav.Link as={Link} to="/Register" className="txt">Register</Nav.Link>
                </Nav>
            </Container>
        </Navbar>
    );
}

export default Navbar_tool;