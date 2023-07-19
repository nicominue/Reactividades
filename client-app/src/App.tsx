import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Header, List, Button } from 'semantic-ui-react';

function App() {
  const [actividades, setActividades] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/actividades')
      .then(response =>{
        //console.log(response);
        setActividades(response.data)
      })
  }, [])

  return (
    <div>
      <Header as='h2' icon='users' content='Reactividades'/>
        <List>              
          {actividades.map((actividad: any) =>(
            <List.Item key={actividad.id}>
              {actividad.titulo}
            </List.Item>
          ))}
        </List>     
    </div>
  );
}

export default App;
