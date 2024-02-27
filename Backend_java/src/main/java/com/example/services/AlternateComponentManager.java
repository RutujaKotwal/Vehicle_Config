package com.example.services;

import java.util.List;

import org.springframework.data.repository.query.Param;

import com.example.dto.SubCompPrice;

public interface AlternateComponentManager {
	//public List<SubCompPrice> getDefaultCompname( int model_id);
	List<String> getCompnameByStd( int mdl_id);
	
	List<String> getCompnameByInt(int mdl_id);
	List<String> getCompnameByExt(int mdl_id);
	public List<SubCompPrice> getConfigurableConfig( int mdl_id ,String Comp_name);
	
	SubCompPrice getFinalConfig(int Alt_id );
	//@Param("mdl_id"), @Param("Comp_name") 
	
//	public List<SubCompPrice> getConfigurableAirbag( int model_id);
//	public List<SubCompPrice> getConfigurableGPSNavigation( int model_id);
//	// interior
//	public List<SubCompPrice> getConfigurableBlueTooth( int model_id);
//	public List<SubCompPrice> getConfigurableInfoSys( int model_id);
//	public List<SubCompPrice> getConfigurableClimateControl(int model_id);
//	//exterior
//	public List<SubCompPrice> getConfigurableAlloy( int model_id);
//	public List<SubCompPrice> getConfigurableLED(int model_id);
//	public List<SubCompPrice> getConfigurableParkingSensor(int model_id);
	
	
	
	
}