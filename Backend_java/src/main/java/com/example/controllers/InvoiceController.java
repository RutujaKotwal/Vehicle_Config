package com.example.controllers;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import com.example.services.InvoiceManager;

import com.example.entities.Invoice;


@RestController
@CrossOrigin("http://localhost:3000")
public class InvoiceController {
	@Autowired
    private InvoiceManager invoicemanager;

	@PostMapping(value="api/invoicestore")
    public void registerCompany(@RequestBody Invoice invoice) {
		invoicemanager.createInvoice(invoice);
    }
	
}
