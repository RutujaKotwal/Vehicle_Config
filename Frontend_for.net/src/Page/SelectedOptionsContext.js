import { createContext, useContext, useState } from 'react';

const SelectedOptionsContext = createContext();

export function SelectedOptionsProvider({ children }) {
  const [altOptions, setaltOptions] = useState([]);
  const [enteredUsername, setEnteredUsername] = useState("");
  const [isauthenticated,setauthentication] = useState(false);
  
  return (
    <SelectedOptionsContext.Provider value={{altOptions, setaltOptions,enteredUsername,setEnteredUsername,isauthenticated,setauthentication}}>
      {children}
    </SelectedOptionsContext.Provider>
  );
}

export function useSelectedOptions() {
  return useContext(SelectedOptionsContext);
}