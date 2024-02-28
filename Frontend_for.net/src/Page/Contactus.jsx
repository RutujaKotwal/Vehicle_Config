import { useEffect, useState } from "react";
import 'bootstrap/dist/css/bootstrap.min.css'; // Import Bootstrap CSS

export default function Contactus() {
  const [getdetails, setDetails] = useState();
  const [msgBody, setMsgBody] = useState();

  const handleOnchange = (event) => {
    setDetails((eml) => ({ ...eml, [event.target.name]: event.target.value }));
    setMsgBody((msg) => ({ ...msg, [event.target.name]: event.target.value }));
    console.log(getdetails);
    console.log(msgBody);
  };

  const sendEmail = (event) => {
    event.preventDefault();

    console.log(JSON.stringify(getdetails));

    fetch("http://localhost:8080/api/sendMail", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({...getdetails,msgBody:msgBody.msgBody}),
    })
      .then((data) => {
        console.log(data);
        alert("Inserted");
        // navigate('/home');
      })
      .catch((error) => {
        console.error("There was a problem with the fetch operation:", error);
      });
  };

  const containerStyle = {
    backgroundImage: 'url("contact.jpg.webp")', // Replace with the actual image path
    backgroundSize: 'cover',
    backgroundPosition: 'center',
    minHeight: '100vh',
    display: 'flex',
    flexDirection: 'column',
    justifyContent: 'flex-start', // Align content at the top
    alignItems: 'center',
    textAlign: 'center', // Center-align text
  };

  const headingStyle = {
    marginTop: '20px', // Adjust as needed
    fontWeight: 'bold',
    fontSize: '24px', // Adjust as needed
    backgroundColor: 'blue', // Add the background color for "Contact us" heading
    padding: '10px', // Add padding for better visibility
    borderRadius: '5px', // Add border radius for rounded corners
    color: 'white', // Adjust text color as needed
  };

  return (
    <div style={containerStyle} className="container mt-5">
      <h2 style={headingStyle}>Contact us</h2>
      <form onSubmit={sendEmail}>
        <div className="mb-3">
          <label htmlFor="name" className="form-label">
            Name
          </label>
          <input
            type="text"
            name="name"
            className="form-control"
            placeholder="Enter your name"
            required
            onChange={handleOnchange}
          />
        </div>

        <div className="mb-3">
          <label htmlFor="email" className="form-label">
            Email
          </label>
          <input
            type="email"
            name="email"
            className="form-control"
            placeholder="Enter your email"
            required
            onChange={handleOnchange}
          />
        </div>

        <div className="mb-3">
          <label htmlFor="query" className="form-label">
            Query
          </label>
          <textarea
            id="msgBody"
            name="msgBody"
            className="form-control"
            placeholder="Enter your query"
            required
            onChange={handleOnchange}
          ></textarea>
        </div>

        <button type="submit" className="btn btn-primary">
          Submit
        </button>
      </form>
    </div>
  );
}