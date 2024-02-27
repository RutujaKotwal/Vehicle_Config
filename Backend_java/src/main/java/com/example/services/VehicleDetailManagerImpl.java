package com.example.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import com.example.dto.Price;
import com.example.repositories.VehicleRepository;

@Service
public class VehicleDetailManagerImpl implements VehicleDetailManager{
	
	@Autowired
	private VehicleRepository vehicledetail_rpo;

	@Override
	public List<String> getVehicleDetailsByCore(int mdl_id) {
		// TODO Auto-generated method stub
		return vehicledetail_rpo.getVehicleDetailsByCore(mdl_id);
	}

	
	  @Override public double getPrice(int mdl_id) { 
		  return vehicledetail_rpo.getPriceByModel(mdl_id).getPrice();
	}
	 

	@Override
	public List<String> getVehicleDetailsByStandard(int mdl_id) {
		return vehicledetail_rpo.getVehicleDetailsByStandard(mdl_id);
	}

	@Override
	public List<String> getVehicleDetailsByInterior(int mdl_id) {
		return vehicledetail_rpo.getVehicleDetailsByInterior(mdl_id);
	}

	@Override
	public List<String> getVehicleDetailsByExterior(int Model_id) {
		return vehicledetail_rpo.getVehicleDetailsByexterior(Model_id);
	}


	@Override
	public String getImagebyId(int mdl_id) {
		// TODO Auto-generated method stub
		return vehicledetail_rpo.getImagebyId(mdl_id);
	}



	
	
}