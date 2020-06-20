import React from "react";
import {
    Text,
    View, 
    ActivityIndicator, 
    ProgressBarAndroid, 
    ProgressViewIOS,
    Button,
    Alert,
    Dimensions
} from "react-native";

const { height, width } = Dimensions.get('window');

export default function App(){
    const onButtonPress = () => {
        Alert.alert(`${new Date().toLocaleTimeString()} button pressed`);
    };
  return(
    <View style={{ padding: 50 }}>
      {Platform.OS === "ios" && <ProgressViewAndroid progress={0.5} />}
      {Platform.OS === "android" && 
        <ProgressBarAndroid 
          styleAttr="Horizontal"
          indeterminate={false}
          color={"blue"}
          progress={0.5} />
      }
      <ActivityIndicator size="large" color="#61DBFB" />
      <Button title="click me" onPress={onButtonPress}/>
      <Text>OS: {Platform.OS}</Text>
      <Text>Height: {height}</Text>
      <Text>Width: {width}</Text>
    </View>
  );
} 
