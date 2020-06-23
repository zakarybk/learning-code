import React, { useState } from "react"
import { StyleSheet, Text, View, TouchableHighlight } from "react-native"

import picMountain from "./assets/gray-asphalt-road-on-cliff.jpg"
import picCave from "./assets/abstract-antelope-canyon-art-blur.jpg"

function ColorButton({ backgroundColor, onPress=f=>f }) { // =f=>f dumby function
  return (
    <TouchableHighlight style={styles.button}
      onPress={() => onPress(backgroundColor)}
      underlayColor="orange"
    >
      <View style={styles.row}>
        <View style={[styles.sample, { backgroundColor }]} />
        <Text style={styles.buttonText}>{backgroundColor}</Text>
      </View>
    </TouchableHighlight>
  )
}

export default function App(){
  const [backgroundColor, setBackgroundColor] = useState("blue");
  return(
    <View style={[styles.container, { backgroundColor }]}>
      <ColorButton backgroundColor="red" onPress={setBackgroundColor} />
      <ColorButton backgroundColor="blue" onPress={setBackgroundColor}/>
      <ColorButton backgroundColor="green" onPress={setBackgroundColor}/>
      <ColorButton backgroundColor="purple" onPress={setBackgroundColor}/>
    </View>
  )
} 

const styles = StyleSheet.create({
  container: {
    flex: 1,
    display: "flex",
    justifyContent: "center",
    alignItems: "center"
  },
  button: {
    margin: 10,
    padding: 10,
    borderWidth: 2,
    borderRadius: 10,
    alignSelf: "stretch",
    backgroundColor: "rgba(255,255,255,0.8)"
  },
  buttonText: {
    fontSize: 30,
    textAlign: "center"
  },
  row: {
    flexDirection: "row",
    alignItems: "center"
  },
  sample: {
    height: 20,
    width: 20,
    borderRadius: 10,
    backgroundColor: "white"
  }
})