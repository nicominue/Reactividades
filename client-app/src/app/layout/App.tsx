import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Header, List, Button, Container } from 'semantic-ui-react';
import {Actividad} from '../models/activity';
import NavBar from './NavBar';

function App() {
  const [actividades, setActividades] = useState<Actividad[]>([]);

  useEffect(() => {
    axios.get<Actividad[]>('http://localhost:5000/api/actividades')
      .then(response =>{
        //console.log(response);
        setActividades(response.data)
      })
  }, [])

  return (
    <>
      {/* <Header as='h2' icon='users' content='Reactividades'/> */}
      <NavBar/> 
      <Container style={{marginTop: '7em'}}>
        <List>              
          {actividades.map(actividad =>(
            <List.Item key={actividad.id}>
              {actividad.titulo}
            </List.Item>
          ))}
        </List> 
      </Container>            
    </>
  );
}

export default App;
