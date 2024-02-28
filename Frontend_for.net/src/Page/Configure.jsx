import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import { useNavigate } from 'react-router-dom';
import DynConfig from './DynConfig';

function Configure() {
  let navigate = useNavigate();
//const {Model_id} = useParams();
    const [coreOptions, setCoreOptions] = useState([]);
    const [selectedData, setSelectedData] = useState("std");
    const [currentModelId, setCurrentModelId] = useState(null);
    const Model_id =sessionStorage.getItem("Model_id");
    const Imagedis = sessionStorage.getItem("Imagedis");
    const handleButtonClick = (data) => {
      console.log('Selected Data:', data);
      setSelectedData(data);
    };
    const handleConfirm = (event) => {
      navigate('/Invoice');
    };
    const handleCancel = (event) => {
      navigate(`/DefaultConfig/${Model_id}`);
    };
    useEffect(() => {
      setCurrentModelId(Model_id); // Set the currentModelId when Model_id changes
      const fetchData = async () => {
        try {
          const coreResponse = await fetch(`http://localhost:8080/api/componentbyc/${Model_id}`);
          if (!coreResponse.ok) {
            throw new Error('Failed to fetch core options');
          }
          const coreData = await coreResponse.json();
          console.log(coreData);
          setCoreOptions(coreData);
        } catch (error) {
          console.error('Error fetching core options:', error);
          // Handle the error as needed, e.g., set error state
        }
      };
      fetchData();
  }, [Model_id]);

    return (
      <div className="card mb-3 custom-card">
      <div className="row g-0">
        <div className="col-md-4">
          <img
            src={Imagedis} // Replace with your actual image URL
            className="img-fluid rounded-start"
            alt="Your Image"
          />
        </div>
        <div className="col-md-8">
          <div className="card-body">
            <h2>Core Options</h2>
            <ul>
              {/* Replace with your actual coreOptions */}
              {coreOptions.map((option, index) => (
                <li key={index}>{option}</li>
              ))}
            </ul>
            <div>
              <DynConfig Model_id={Model_id} sltdata={selectedData}></DynConfig>
            </div>
            <div>
              <button
                className="btn btn-success"
                onClick={() => { handleButtonClick("std") }}
              >
                Standard
              </button>
              <button
                className="btn btn-success"
                onClick={() => { handleButtonClick("interior") }}
              >
                Interior
              </button>
              <button
                className="btn btn-success"
                onClick={() => { handleButtonClick("exterior") }}
              >
                Exterior
              </button>
              <button
                className="btn btn-danger"
                onClick={handleCancel}
              >
                Cancel
              </button>
              <button
                className="btn btn-success"
                onClick={handleConfirm}
              >
                Confirm Order
              </button>
            </div>
          </div>
        </div>
      </div>
    </div>
    )
}


export default Configure
