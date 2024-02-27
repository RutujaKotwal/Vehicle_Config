package com.example.services;

import java.util.List;

import org.springframework.data.repository.query.Param;

public interface VehicleDetailManager {

	public List<String> getVehicleDetailsByCore(int mdl_id);
	public List<String> getVehicleDetailsByStandard(int mdl_id);
	public List<String> getVehicleDetailsByInterior(int mdl_id);
	public List<String> getVehicleDetailsByExterior(int mdl_id);
	public double getPrice(int mdl_id);
	String getImagebyId(int mdl_id);
}