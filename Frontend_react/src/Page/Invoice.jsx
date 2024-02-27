import { useEffect, useState } from "react"
import { useSelectedOptions } from './SelectedOptionsContext';
import { useNavigate } from 'react-router-dom';
import { jsPDF } from "jspdf";
import html2canvas from "html2canvas";

function Invoice(){
  let navigate = useNavigate();
const {altOptions,enteredUsername }= useSelectedOptions();
const arr1 = Object.values(altOptions);
const [finalconfigitems, setFinalconfigitems] = useState([]);
const [data, setData] = useState(null);
const price = sessionStorage.getItem("price");
var [finalprice, setFinalprice] = useState(price);
const quantity = sessionStorage.getItem("quantity");
const Model_id = sessionStorage.getItem("Model_id");
const handleConfigure = (event) => {
  navigate(`/Configure`);
};
const totalprice = quantity * finalprice * 0.12 + quantity * finalprice;

const [forminvoicedata, setFormData] = useState({
  username: enteredUsername ,
  date: new Date().toLocaleDateString(),
  mdl_id:Model_id,
  quantity:quantity,
  total_price:totalprice
});

const handleConfirm = (evt) => {
    evt.preventDefault();
    console.log(forminvoicedata);
    alert("invoice has been saved");
     html2canvas(document.documentElement).then((canvas) => {
    const imgData = canvas.toDataURL("image/png");
    const pdf = new jsPDF();
    pdf.addImage(imgData, "PNG", -150, 0);
    pdf.save("invoice.pdf");
  });

    let demo = JSON.stringify(forminvoicedata);
    console.log(demo);
    fetch("http://localhost:8080/api/invoicestore", {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: demo
    });
  };
useEffect(() => {
  async function fetchdata() {
    const fetchedData = await Promise.all(
      arr1.map((option) =>
        fetch(`http://localhost:8080/api/invoice/${option}`)
          .then((response) => response.json())
          .catch((error) => {
            console.error("Error fetching data:", error);
          })
      )
    );

    setFinalconfigitems(fetchedData);

    const configitemprices = fetchedData.map((option) => option["price"]);
    var sum = 0;
    configitemprices.map((option) => (sum = sum + parseFloat(option)));
    setFinalprice(sum + parseFloat(finalprice));
    console.log(finalprice);
    setData("Fetched data");
    
  }

  fetchdata();
}, []);
  return (
    <div>
      <div>
        <h1>INVOICE</h1>
                <h3>Configured components : </h3>
                <ul>
                  {finalconfigitems.map((option, index) => (
                  <li key={index}> {option.sub_type +
                  " ( Price Difference : " +
                  option.price +
                  " )"}</li>
        ))}
      </ul>
              </div>
              <div></div>
              <div style={{ marginBottom: 5, marginLeft: 20 }}>
              <b>Price : </b>
              {finalprice}
            </div>

            <div style={{ marginBottom: 5, marginLeft: 20 }}>
              <b>Quantity : </b>
              {quantity}
            </div>

            <div style={{ marginBottom: 5, marginLeft: 20 }}>
              <b>Total Price : </b>
              {quantity * finalprice}
            </div>

            <div style={{ marginBottom: 5, marginLeft: 20 }}>
              <b>Taxes : </b>
              {quantity * finalprice * 0.12}
            </div>

            <div style={{ marginBottom: 5, marginLeft: 20 }}>
              <b>
                <i>Final Amount : </i>
              </b>
              {quantity * finalprice * 0.12 + quantity * finalprice}
            </div>
            <hr />
            <div style={{textAlign:"center"}}>
            <button variant="contained" color="success" style={{ marginRight: 20, marginBottom: 90 }} onClick={handleConfirm}>
              Confirm
            </button>
            <button variant="contained" color="success" style={{ marginRight: 20, marginBottom: 90 }} onClick={handleConfigure}>
              Cancel
            </button>
            </div>
    </div>
  );
}

export default Invoice;
