package com.example.repositories;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.example.entities.Model_master;

import jakarta.transaction.Transactional;
@Repository
@Transactional
public interface ModelRepository extends JpaRepository<Model_master, Integer> {
	@Query(value = "SELECT distinct v.* FROM segment_master AS s INNER JOIN Mfg_master AS m ON s.Seg_id = m.Seg_id INNER JOIN Model_master AS v ON v.Seg_id = :Seg_id AND v.Mfg_id = :Mfg_id",nativeQuery=true)
	List<Model_master> getVariants(@Param("Seg_id")int seg_id,@Param("Mfg_id")int mfg_id);
}
