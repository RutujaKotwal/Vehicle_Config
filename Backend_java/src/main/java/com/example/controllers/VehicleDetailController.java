package com.example.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

//import com.example.dtos.Price;
import com.example.services.VehicleDetailManager;


@RestController
@CrossOrigin
public class VehicleDetailController {
	@Autowired
	private VehicleDetailManager vehicledetail_mgr;
	
	@GetMapping("api/componentbyc/{mdl_id}")
	public List<String> getVehicleDetailsByCore(@PathVariable int mdl_id){
		return vehicledetail_mgr.getVehicleDetailsByCore(mdl_id);
	}
	
	@GetMapping("api/componentbys/{mdl_id}")
	public List<String> getVehicleDetailsByStandard(@PathVariable int mdl_id){
		return vehicledetail_mgr.getVehicleDetailsByStandard(mdl_id);
	}
	
	
	
	  @GetMapping("api/price/{mdl_id}") 
	  public double getPrice(@PathVariable int mdl_id){ 
		  return vehicledetail_mgr.getPrice(mdl_id);
	}
	 
	
	@GetMapping("api/componentbyi/{mdl_id}")
	public List<String> getVehicleDetailsByInterior(@PathVariable int mdl_id){
		return vehicledetail_mgr.getVehicleDetailsByInterior(mdl_id);
	}
	
	@GetMapping("api/componentbye/{mdl_id}")
	public List<String> getVehicleDetailsByExterior(@PathVariable int mdl_id){                                            
		return vehicledetail_mgr.getVehicleDetailsByExterior(mdl_id);
	}
	
	@GetMapping("api/image/{mdl_id}")
	public String getImagebyId(@PathVariable int mdl_id) {
		return vehicledetail_mgr.getImagebyId(mdl_id).toString();
	}

	
}